using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        DisplayActiveSite();
        // foreach(FileManager.MetaFile test in userPieceList)
        // {
        //     MolFile molFile = new MolFile(test);
        // 	Transform parent = new GameObject(test.Name).transform;
        // 	parent.transform.parent = GameObject.Find("BasePoint").transform;
        // 	parent.transform.localPosition = Random.insideUnitSphere * 50; 
        // 	DisplayAtoms.Display( molFile.GetAtomDetailList(), parent );
        // }


        //CenterActiveSite();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DisplayActiveSite()
    {
        FileManager.MetaFile[] userPieceList;
        FileManager.MetaFile[] activeSite;
        FileManager.MetaFile[] activeSiteAnchors;
        userPieceList = FileManager.GetPieces("UserPiece");
        activeSite = FileManager.GetPieces("ActiveSite"); // TODO: update for multiple Active Sites
        activeSiteAnchors = FileManager.GetPieces("ActiveSite/Anchors"); // TODO: update for multiple Active Sites

        MolFile molFile = new MolFile(activeSite[0]); // TODO: be able to select other Active Sites (if available)

        Transform activeSiteTrans = CreateTransform("ActiveSite", GameObject.Find("BasePoint").transform);
        Transform molControlTrans = CreateTransform("MolControl", activeSiteTrans);
        Transform molObjectTrans = CreateTransform("MolObject", molControlTrans);
        
        DisplayAtoms.Display(molFile.GetAtomDetailList(), molObjectTrans);


        foreach (FileManager.MetaFile anchor in activeSiteAnchors)
        {
            activeSiteTrans = CreateTransform("ActiveSiteAnchor", GameObject.Find("BasePoint").transform);
            molControlTrans = CreateTransform("MolControl", activeSiteTrans);
            molObjectTrans = CreateTransform("MolObject", molControlTrans);

            DisplayAtoms.Display(molFile.GetAtomDetailList(), molObjectTrans);
        }
    }

    Transform CreateTransform(string name, Transform parent, Vector3 localPosition = default(Vector3))
    {
        Transform trans = new GameObject(name).transform;
        trans.transform.parent = parent;
        trans.transform.localPosition = localPosition;

        return trans;
    }

    //void CenterActiveSite()
    //{
    //    GameObject bp = GameObject.Find("BasePoint");
    //    Bounds bounds = GetMaxBounds(bp);
    //    bp.transform.localPosition = -(bounds.center/2);
        
    //}
}
