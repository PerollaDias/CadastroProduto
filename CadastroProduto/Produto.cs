public class Produto
{
    public double lucro { get; set; }
    public string codigo { get; set; }
    public string descricao { get; set; }
    public double precoaqs { get; set; }
    public double valorvenda { get; set; }
   
    public Produto()
    {

    }
    public Produto(double lucro, string codigo, string descricao, double precoaqs, double valorvenda)
    {
        this.lucro = lucro;
        this.codigo = codigo;
        this.precoaqs = precoaqs;
        this.valorvenda = valorvenda;
        this.descricao = descricao;

        
       

        

    }
}