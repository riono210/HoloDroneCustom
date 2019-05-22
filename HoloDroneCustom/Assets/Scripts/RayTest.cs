using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RayTest : MonoBehaviour, IInputClickHandler
{

    [HideInInspector] public GameObject attachPrefab; // 生成するプレファブ
    public GameObject blocksParent; // GameObjの親

    public SelectBlock selectBlock;
    private int selectIndex; // 選択しているinexd

    // Use this for initialization
    void Start()
    {
        selectIndex = 0;
        attachPrefab = selectBlock.GetAttachPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        //RayHit ();
        // attachするプレファブの変更
        if (selectIndex != selectBlock.GetIndex())
        {
            attachPrefab = selectBlock.GetAttachPrefab();
            selectIndex = selectBlock.GetIndex();
        }
        //AttachBlocks();
    }

    // raycastを飛ばす
    public void RayHit()
    {
        // rayの設定
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // 返り値
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.Log(hit.normal);
        }
    }

    public void AttachBlocks()
    {
        // rayの設定
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = GazeManager.Instance.HitInfo;

        Debug.Log("hit:" + hit.normal);

        //if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
        //Debug.Log (hit.normal + " " + hit.collider.transform.position);

        // 追加
        if (Input.GetMouseButtonDown(0))
        {
            Transform blocksParentTf = blocksParent.transform;
            Instantiate(attachPrefab,
                hit.collider.transform.position + hit.normal,
                Quaternion.identity,
                blocksParentTf);
        }

        // 削除
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(hit.collider.gameObject);
        }
        //}
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        RaycastHit hit = GazeManager.Instance.HitInfo;
        GameObject hitObj = GazeManager.Instance.HitObject;

        if (hitObj.tag == "bloxs")
        {
            Debug.Log("hit:" + hit.collider.transform.position);
            Vector3 exchange = hit.normal;
            exchange = new Vector3(exchange.x * 0.1f, exchange.y * 0.1f, exchange.z * 0.1f);

            // ブロックの設置
            Transform blocksParentTf = blocksParent.transform;
            GameObject atObj = Instantiate(attachPrefab,
                hit.collider.transform.position + exchange,
                Quaternion.identity,
                blocksParentTf);

            atObj.tag = "bloxs";

            //throw new System.NotImplementedException();
        }
    }
}