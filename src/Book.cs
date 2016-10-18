public class Book{
	private const string d_title = "NO TITLE";
	private const double d_price = 0.0;
	private const string d_edition = "NA";
	private string p_title;
	private double p_price;
	private string p_edition;

	public Book() : this(d_title, d_price, d_edition){}	
	public Book(string raw) : this (ParseTitle(raw), ParsePrice(raw), ParseEdition(raw)){}
	public Book(string title, double price, string edition){
		p_title = title;
		p_price = price;
		p_edition = edition;
	}

	public string Title{get{return p_title != "" ? p_title : d_title;} set{p_title = value;}}
	public double Price{get{return p_price;} set{p_price = value;}}
	public string Edition{get{return p_edition != "" ? p_edition : d_edition;} set{p_edition = value;}}
	
	public override string ToString(){
		return "" + Title + "," + Price + "," + Edition;
	}
	public static string ParseTitle(string raw){
	}
	public static double ParsePrice(string raw){
	}
	public static string ParseEdition(string raw){
	}
}	
