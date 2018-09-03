using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;
public class SwayWall : MonoBehaviour {
  //CSVの中身を格納するリスト
  private List<string[]> addressDatas = new List<string[]>();
  // CSVの行を取得する変数
  private int i = 0;
	// 最初に取得したいファイルを読み込む
	void Start () {
	// csvファイル名
    var fileName = "not0_suityoku";
    // Resourcesのcsvフォルダ内のcsvファイルをTexttAssetとして取得
		var csvFile = Resources.Load("csv/" + fileName) as TextAsset;
    // csvファイルの内容をStringReaderに変換
    var reader = new StringReader(csvFile.text);
    // csvファイルの内容を一行ずつ末尾まで取得しリストを作成
    while(reader.Peek() > -1) {
      // 一行読み込む
      var lineData = reader.ReadLine();
      // カンマ(,)区切りのデータを文字列の配列に変換
      var address = lineData.Split (',');
      // リストに追加
      addressDatas.Add(address);
      // 末尾まで繰り返し...
    }
	}

	// だいたい60FPSらしいから1/60で取得した値であればfor文として利用できるはず
  // Unityでの1/60での取得ができない場合はまた別のメソッドを作る必要あり
	void Update () {
    // 3Dベクトルと位置の表現
	  Vector3 vector = new Vector3();
    // CSVからX,Y,Z,の値を代入
		float acSwayX = Single.Parse(addressDatas[i][3]);
		float acSwayY = Single.Parse(addressDatas[i][4]);
    float acSwayZ = Single.Parse(addressDatas[i][5]);
    // Unityとiphoneの傾きの値を合わせる
    acSwayX = acSwayX * 57.325f - 180;
    acSwayY = acSwayY * 57.325f - 180;
    acSwayZ = acSwayZ * 57.325f - 180;
    // オブジェクトに傾きを与える
    this.transform.localEulerAngles = new Vector3 (acSwayX,acSwayY,acSwayZ);
    // CSVを次の行へ
    i = i + 1;
  }
}
