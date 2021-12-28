class HelloWorld
{
	static void Main()
	{
		string message1, message2 = "hello world";  //定义两个变量，英文逗号分隔
		
		// System.Console.WriteLine("你的名字是：");  // 输入光标会自动换行
		System.Console.Write("你的名字是：");  //优化方式，去掉Line
		
		message1 = System.Console.ReadLine();  //获取输入内容，赋值给变量
		
		System.Console.WriteLine("你好，" + message1); //字符串拼接
		System.Console.WriteLine("你好，{0}", message1);//字符串格式化
		
		
		// message1 = "this is my first c code";
		// System.Console.WriteLine(message1);
		
		System.Console.WriteLine(message2);
	}
}