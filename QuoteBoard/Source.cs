public class Source {
    
    private string name = "";
    private string url = "";

    public Source(string name, string url = "") {
        this.name = name;
        this.url = url;
    }

    public string getName() {
        return name;
    }

    public string getUrl() {
        return url;
    }
}