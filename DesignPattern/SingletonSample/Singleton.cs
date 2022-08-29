using System;

public class Singleton {

    private static Singleton singleton;
    
    //コンストラクタ
    private Singleton() {                                 
        Console.WriteLine("インスタンスを生成しました。");
    }

    public static Singleton getInstancs() {

        if (singleton ==null) {

            singleton = new Singleton();
        }

        return singleton;
    }
}
