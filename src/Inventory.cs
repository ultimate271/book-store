public class Inventory{
	private Dictionary <Book, int> p_bookshelf;
	
	private void init (){
		p_bookshelf = new Dictionary <Book, int>();
	}
	
	public void LoadInventory (System.IO.StreamReader inFile){
		
	}
	
	public void SaveInventory (System.IO.StreamWriter outFile){
		foreach (Book b : p_bookshelf.Keys){
			outFile.WriteLine(Book2Line(b));
		}
	}
	
	/**
	Creates a new entry in the dictionary
	*/
	private void AddInventoryItem(String line){
		
	}
	
	/**
	Creates a new entry in the dictionary
	*/
	private void AddInventoryItem(Book b, int stock){
		p_bookshelf.Add(b, stock);
	}
	
	private String Book2Line(Book b){
		return "" + b + "," + p_bookshelf[b];
	}
}