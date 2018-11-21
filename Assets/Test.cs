using UnityEngine;
using System.Collections;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

}

public class Test : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		int [] array = new int[5];

		array [0] = 30;
		array [1] = 90;
		array [2] = 80;
		array [3] = 40;
		array [4] = 20;

		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

		for (int i = 4; i >=0; i--){
			Debug.Log (array [i]);
		}


		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
	}

	// Update is called once per frame
	void Update () {

	}
}



