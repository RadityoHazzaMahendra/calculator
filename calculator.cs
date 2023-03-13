class Calculator
{
	static void main (string[] args)
	{
		int a = 10;
		int b = 6;
	
		Console.Writeline("hasil penambahan: (0)-(1)=(2)",a,b,penambahan(a,b));
		Console.Writeline("hasil pengurangan: (0)-(1)=(2)",a,b,pengurangan(a,b));
		
		Console.Writeline("\ntekan sembarang key untuk keluar");
		Console.Readkey();
	}
	static int penambahan (int a, int b)
	{
		return a+b;
	}
	static int pengurangan (int a, int b)
	{
		return a-b;
	}
}
