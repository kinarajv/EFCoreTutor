namespace MyProgram; 
class Program 
{
	static void Main() 
	{
		Human human = new Human("cek");
		human.CountName();
	}
}
class Human 
{
	private string name = null!;
	public string x;
	public EventHandler? myEvent;
	public EventHandler myEvent2 = null!;
	// Variable
	// ? => nullable (boleh null boleh tidak)
	// ! => nullforgiving operator tidak mungkin null
	public int CountName() {
		return name.Length;
	}
}