public class Book{
	private string p_title;
	private double p_price;

	public Book() : this("", 0.0){
	}
	public Book(String title, double price){
		p_title = title;
		p_price = price;
	}

	public string Title{
		get{return p_title;}
		set{p_title = value;}
	}
	public override string ToString(){
		return "" + Title;
	}
}	
