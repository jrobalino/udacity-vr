
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UdacityFunEffects : MonoBehaviour {

    public const float SUN_ROTATION_SPEED = 40f;
    private Vector3 SUN_UP = new Vector3(70f, 0f, 0f); //vectors cannot be consts :(
    private Vector3 SUN_DOWN = new Vector3(220f, 0f, 0f);

    public Light sunLight;
    public Light flashLight;

    public int numCubes = 10;
    public GameObject cubePrefab;

    public Teleport cube;
    public Teleport sphere;

    private GameObject activeShape;
    private bool isSunUp = true;

    public GameObject[] cubes;

    // Shrink/Grow
    private Vector3 startingScale;
    public float growScale = .25f;
    public float shrinkScale = .25f;
    public float maxScale = 3.0f;
    public GameObject MyName;
    public GameObject MyInstructions;

    public string minTextName = "The mass of the system must remain constant!";
    public string minTextInstruction = "Please grow the cube before the universe ceases to exist.";
    public string maxTextName = "Oh my! Aren't you ambitious?";
    public string maxTextInstruction = "Please shrink the cube to avoid being crushed.";

    private Text nameText;
    private Text instructionText;

    // Use this for initialization
    void Start () {
        cubes = new GameObject[numCubes];

        if (cube.gameObject.activeInHierarchy)
            activeShape = cube.gameObject;
        else
            activeShape = sphere.gameObject;
	}

    public void updateText()
    {
        if (activeShape.transform.localScale.x == 0)
        {
            nameText = MyName.GetComponent<Text>();
            instructionText = MyInstructions.GetComponent<Text>();
            nameText.fontSize = 72;
            nameText.text = minTextName;
            instructionText.text = minTextInstruction;
            MyName.SetActive(true);
            MyInstructions.SetActive(true);
        }
        else if (activeShape.transform.localScale.x >= maxScale)
        {
            nameText = MyName.GetComponent<Text>();
            instructionText = MyInstructions.GetComponent<Text>();
            nameText.fontSize = 72;
            nameText.text = maxTextName;
            instructionText.text = maxTextInstruction;
            MyName.SetActive(true);
            MyInstructions.SetActive(true);
        }
        else
        {
            MyInstructions.SetActive(false);
            MyName.SetActive(false);
        }
    }

    public void Grow()
    {
        if (activeShape.transform.localScale.x < maxScale)
        {
            activeShape.transform.localScale += new Vector3(growScale, growScale, growScale);

        }
        updateText();
    }

    public void Shrink()
    {
        if (activeShape.transform.localScale.x >= shrinkScale)
        {
            activeShape.transform.localScale -= new Vector3(shrinkScale, shrinkScale, shrinkScale);

        }
        updateText();
        
    }

    public void ChangeParticleColor()
    {
        Color c = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
        cube.GetComponent<ParticleSystem>().startColor = c;
        sphere.GetComponent<ParticleSystem>().startColor = c;
    }

    public void ToggleSun()
    {
        StopAllCoroutines();
        isSunUp = !isSunUp;
        StartCoroutine(AnimateSun(isSunUp));
        updateText();
    }

    public void ToggleFlashLight()
    {
        flashLight.gameObject.SetActive(!flashLight.gameObject.activeInHierarchy);
    }

    public void ToggleShape()
    {
        if (cube.gameObject.activeInHierarchy)
        {
            Vector3 cubePosition = cube.transform.position;
            cube.gameObject.SetActive(false);
            sphere.gameObject.SetActive(true);
            sphere.transform.position = cubePosition;

            activeShape = sphere.gameObject;
        } else
        {
            Vector3 spherePosition = sphere.transform.position;
            cube.gameObject.SetActive(true);
            sphere.gameObject.SetActive(false);
            cube.transform.position = spherePosition;

            activeShape = cube.gameObject;
        }
    }

    public void SpawnRandomCubes()
    {
        StopCoroutine("SpawnCubesWithDelay");
        StartCoroutine("SpawnCubesWithDelay");
    }

    private IEnumerator SpawnCubesWithDelay()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            Destroy(cubes[i]);
            cubes[i] = Instantiate(cubePrefab);
            cubes[i].GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
            cubes[i].transform.position = new Vector3(Random.Range(-2f, 2f), 25f, Random.Range(-2f, 2f));
            Rigidbody r = cubes[i].GetComponent<Rigidbody>();
            r.angularVelocity = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));

            yield return new WaitForSeconds(.1f);
        }
    }

    private IEnumerator AnimateSun(bool isSunUp)
    {
        Quaternion target = Quaternion.Euler(isSunUp ? SUN_UP : SUN_DOWN);
        float startAngle = Quaternion.Angle(sunLight.transform.rotation, target);
        while (true)
        {
            float currAngle = Quaternion.Angle(sunLight.transform.rotation, target);
            if (currAngle > 0.5f) {
                sunLight.transform.Rotate(new Vector3(SUN_ROTATION_SPEED * Time.deltaTime, 0f, 0f));
                float intensity = currAngle / startAngle;
                if (isSunUp)
                    intensity = 1f - intensity;

                sunLight.intensity = intensity;

                yield return new WaitForEndOfFrame();
            } else {
                break;
            }
        }
    }
}
