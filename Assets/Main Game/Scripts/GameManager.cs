using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text TxtScore;
    private int _score = 0;
    public int Score { get { return _score; } set { 
            _score = value;
            TxtScore.text = "" + value;
                } }
    static public int PlayerLayerID = 3;
    static public int CubeTriggerLayerID = 6;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
