namespace Levantamento.src
{
    using System;

    public class computador : EntidadeBase
    {
   

        public computador(string nome_computador, string usuario, tipocomput fk_tipo, string fk_modelo, string endereco_ip, int patrimonio, int ano_aquisicao, string fk_setor, bool excluido) 
        {
            this.nome_computador = nome_computador;
                this.usuario = usuario;
                this.fk_tipo = fk_tipo;
                this.fk_modelo = fk_modelo;
                this.endereco_ip = endereco_ip;
                this.patrimonio = patrimonio;
                this.ano_aquisicao = ano_aquisicao;
                this.fk_setor = fk_setor;
                this.Excluido = excluido;
               
        }
            private string nome_computador { get; set; }

    public string usuario { get; set; }
    private tipocomput fk_tipo { get; set; }

    private string fk_modelo { get; set; }

    private string endereco_ip { get; set; }  
    private int patrimonio { get; set; }
    private int ano_aquisicao { get; set; }

    private string fk_setor { get; set; }
    private bool Excluido { get; set; }

        public computador(int id , string nome, string usuario, tipocomput fk_tipo, string modelo, string endereco_ip, int patrimonio, int ano_aquisicao, string fk_setor){

     this.id = id;

     this.nome_computador = nome; 
     this.usuario = usuario;

     this.fk_tipo  = fk_tipo;
    
     this.fk_modelo = modelo;

     this.endereco_ip = endereco_ip; 

     this.patrimonio = patrimonio; 

     this.ano_aquisicao = ano_aquisicao;

     this.fk_setor = fk_setor;
    
     this.Excluido = false;


        }

        public override string ToString()
        {
         string retorno = "";
    retorno += "Usuario: " + this.usuario + Environment.NewLine;

     retorno += "Nome do computador: " + this.nome_computador + Environment.NewLine; 

     retorno += "Tipo: " +this.fk_tipo + Environment.NewLine; 
    
      retorno += "Modelo: "+ this.fk_modelo + Environment.NewLine; 

     retorno += "IP: " + this.endereco_ip + Environment.NewLine; 
    
     retorno += "Patrimônio: "+  this.patrimonio + Environment.NewLine; 

    retorno += "Ano aquisição: "+ this.ano_aquisicao+ Environment.NewLine; 

     retorno += "Setor: " + this.fk_setor+ Environment.NewLine; 

        return retorno;
        }

        public string retornaComputador(){

            return this.nome_computador;
        }

        public int retornaId(){

            return this.id;
        }

        public void Excluir (){

            this.Excluido = true;

        }
        public bool retornaExcluido(){ 
            return this.Excluido;
        }


       

    }
    
}