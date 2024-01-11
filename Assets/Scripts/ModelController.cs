using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{

    public List<GameObject> models;

    private int currentIndex = 0;

    private void Start()
    {
        ChangeModel(0);
    }

    public void ChangeModel(int newIndex)
    {
        models[currentIndex].SetActive(false);

        models[newIndex].SetActive(true);

        currentIndex = newIndex;
    }

    public void Next()
    {
        int nextIndex = currentIndex+1;
        if (nextIndex >= models.Count)
        {
            nextIndex = 0;
        }
        ChangeModel(nextIndex);
    }

    public void Previous()
    {
        int previousIndex = currentIndex - 1;
        if (previousIndex < 0)
        {
            previousIndex = 0;
        }
        ChangeModel(previousIndex);
    }
}
