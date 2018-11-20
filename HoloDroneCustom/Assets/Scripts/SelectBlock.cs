using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBlock : MonoBehaviour {

	public List<GameObject> prefabList; // ブロック一覧
	private int prefablistCount; // リストの要素数
	private int selectIndex; // 選択しているindex

	// Use this for initialization
	void Start () {
		prefablistCount = prefabList.Count;
		selectIndex = 0;
	}

	// Update is called once per frame
	void Update () {

	}

	// ボタンにつける indexの設定
	public void SetIndex (int num) {
		selectIndex = num;
	}

	// indexにセットされているプレファブを返す
	public GameObject GetAttachPrefab () {
		return prefabList[selectIndex];
	}

	public int GetIndex () {
		return selectIndex;
	}
}