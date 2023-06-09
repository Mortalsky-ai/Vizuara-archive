using UnityEngine;

public class ArrayModifier : MonoBehaviour
{
    public GameObject objectToRepeat;
    public float spacingPerpendicular;
    public float spacingPlanar;
    public int rowCount;
    public int columnCount;

    public Vector3 initialPosition;
    public Vector3 initialRotation;

    private GameObject parentObject;

    void Start()
    {
        // Create the parent GameObject as a child of the current GameObject
        parentObject = new GameObject("ArrayParent");
        parentObject.transform.SetParent(transform);

        // Set the initial position and rotation of the parent object
        parentObject.transform.localPosition = initialPosition;
        parentObject.transform.localRotation = Quaternion.Euler(initialRotation);

        // Create the array of objects
        for (int row = 0; row < rowCount; row++)
        {
            for (int column = 0; column < columnCount; column++)
            {
                // Calculate the position of each object in the array
                Vector3 position = new Vector3(column * spacingPlanar, 0f, row * spacingPerpendicular);

                // Instantiate the object at the calculated position
                GameObject clone = Instantiate(objectToRepeat, parentObject.transform.position + position, Quaternion.identity);

                // Make the new object a child of the parent GameObject
                clone.transform.parent = parentObject.transform;
            }
        }
    }
}
