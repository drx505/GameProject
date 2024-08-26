using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public TMPro.TMP_Text InKublo;
    public TMPro.TMP_Text InNidus;
    public TMPro.TMP_Text InBarracks;
    public TMPro.TMP_Text InLuft;
    public int IK = 50;
    public int IN = 50;
    public int IB = 0;
    public int IL = 0;
    public bool icob = true;
    public bool itol = true;
    public enemy en;
    // Start is called before the first frame update
    void Start()
    {
        InKublo.text = IK.ToString();
        InNidus.text = IN.ToString();
        InBarracks.text = IB.ToString();
        InLuft.text = IL.ToString();
    }
    void Update()
    {
        InKublo.text = IK.ToString();
        InNidus.text = IN.ToString();
        InBarracks.text = IB.ToString();
        InLuft.text = IL.ToString();
        if (IB > 24)
        {
            IK += 1;
            IB -= 1;
        }
        if (IL > 24)
        {
            IN += 1;
            IL -= 1;
        }
    }
    // Update is called once per frame
    public void A(Vector3 pos)
    {
        en.PA(pos);
    }
    public void LumNKM()
    {
        IK -= 1;
    }
    public void LumNKP()
    {
        IK += 1;
    }
    public void LumIKM()
    {
        IN -= 1;
    }
    public void LumIKP()
    {
        IN += 1;
    }
    public void LumNPP()
    {
        IB += 1;
    }
    public void LumNPM()
    {
        IB -= 1;
    }
    public void LumIPP()
    {
        IL += 1;
    }
    public void LumIPM()
    {
        IL -= 1;
    }
    public void NPM6()
    {
        IB -= 6;
    }
    public void IKP6()
    {
        IN += 6;
    }
    public void IPM8()
    {
        IL -= 8;
    }
    public void NKP8()
    {
        IK += 8;
    }
    public void EnterGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
