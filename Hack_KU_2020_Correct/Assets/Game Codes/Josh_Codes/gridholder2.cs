using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridholder2 : MonoBehaviour
{

    private int rows = 200;
    private int cols = 200;
    private float tilesize = 1;


    public GameObject plains;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
      GameObject referenceTile = (GameObject)Instantiate(Resources.Load("plains911"));
      for (int row = 0 ; row < rows ; row++)
      {
        for (int col = 0 ; col < cols; col++)
        {
          GameObject tile = (GameObject)Instantiate(referenceTile, transform);

          float posX = col * tilesize;
          float posY = row * -tilesize;

          tile.transform.position = new Vector3(posY, 1, posX);
        }
      }
      Destroy(referenceTile);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
