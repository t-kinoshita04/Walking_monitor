using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class GetGyro : MonoBehaviour
{
    private bool buttonStart;
    private List<float[]> list = new List<float[]>();
    private string timestamp;

    void Start()
    {
        buttonStart = false;
        // iPhoneの向きを縦に固定
        Screen.orientation = ScreenOrientation.Portrait;
    }

    void Update()
    {
        // 傾きセンサー取得
        var gyr_x = Input.gyro.attitude.x;
        var gyr_y = Input.gyro.attitude.y;
        var gyr_z = Input.gyro.attitude.z;
        // 取得データをlistに保持
        if (buttonStart)
        {
            list.Add(new float[3] { gyr_x, gyr_y, gyr_z });
        }
    }

    // Startが押されたとき
    public void OnClickStart()
    {
        if (!buttonStart)
        {
            buttonStart = true;

            Debug.Log("button = true");
            // 計測開始時刻を取得
            timestamp = System.DateTime.Now.ToString("yyyyMMddHHmmss");
            Debug.Log("timestamp : " + timestamp);
        }
    }

    // Stopが押されたとき
    public void OnClickStop()
    {
        if (buttonStart)
        {
            buttonStart = false;

            Debug.Log("button = false");
            // pathを指定してtimestamp.csvを作成 (例)20181004133015.csv
            string filePath = Application.persistentDataPath + "/" + timestamp + ".csv";
            Debug.Log("filepath : " + filePath);
            // listに保存していたデータをcsvに書き込み
            foreach (var arr in list)
            {
                string addText = string.Format("{0},{1},{2}\n", arr[0], arr[1], arr[2]);
                File.AppendAllText(filePath, addText);
            }
            // list内データを消去
            list.Clear();
        }
    }
}
