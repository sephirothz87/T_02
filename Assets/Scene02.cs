using UnityEngine;
using System.Collections;

public class Scene02 : MonoBehaviour {

    class General
    {
        public int id;
        public string name;
        public string picture;

        public General(int id,string name,string picture)
        {
            this.id = id;
            this.name = name;
            this.picture = picture;
        }
    }

	// Use this for initialization
	void Start () {
        Debug.Log("start");

        //MOCK 获取双方阵容
        General a1 = new General(1,"xiahoudun", "general_01_xiahoudun");
        General b1 = new General(2, "zhangfei", "general_02_zhangfei");

        //没用明白
        //UIAtlas atlas = Resources.Load("general_01_xiahoudun", typeof(UIAtlas)) as UIAtlas;
        //GameObject parent = GameObject.Find("bkg_02");
        //UISprite sprite = NGUITools.AddSprite(parent, atlas, "1");
        //sprite.MakePixelPerfect();
        //parent.GetComponent<UIGrid>().repositionNow = true;

        Debug.Log(a1.picture);
        Debug.Log(b1.picture);

        //可以取到，暂时不知道怎么用
        Texture2D a1_res = Resources.Load(a1.picture) as Texture2D;
        Texture2D b1_res = Resources.Load(b1.picture) as Texture2D;

        //取到的是空
        //Sprite a1_res = Resources.Load(a1.picture) as Sprite;
        //Sprite b1_res = Resources.Load(b1.picture) as Sprite;

        //取到的是空
        //GameObject a1_res = Resources.Load(a1.picture) as GameObject;
        //GameObject b1_res = Resources.Load(b1.picture) as GameObject;

        Debug.Log(a1_res);
        Debug.Log(b1_res);
        
        Debug.Log(GameObject.Find("gen_a1"));
        Debug.Log(GameObject.Find("gen_b1"));

        GameObject.Find("gen_a1").;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
