namespace ProgramaCAO.Sistema.Solucao_master.Dominio
{
    public class Pedidos
    {
        public int IdAnimal { get; set; }
        public int IdCliente { get; set; }        
        public string Especie { get; set; }
        public double PrecoTotal { get; set; }

        public Pedidos() {}

        public Pedidos(int idanimal, int idcliente, string especie, double preco)
        {
            this.IdAnimal=idanimal;
            this.IdCliente=idcliente;            
            this.Especie=especie;
            this.PrecoTotal=preco;
        } 
    } //no cadastro referenciar as classes animal e cliente
}