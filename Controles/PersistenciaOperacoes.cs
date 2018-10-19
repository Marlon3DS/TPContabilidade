using Modelos;

namespace Controles
{
    class PersistenciaOperacoes : Persistencia
    {
        public override void EmpacotarParametros(object objeto, Metodo metodo)
        {
            Operacao operacao = (Operacao)objeto;
            Acesso.LimparParametros();
            if (metodo == Metodo.Alterar || metodo == Metodo.Excluir)
            {
                Acesso.AdicionarParametros("@Id", operacao.Id);
            }
            else
            {
                if (metodo == Metodo.Alterar || metodo == Metodo.Inserir)
                {                    
                    Acesso.AdicionarParametros("@Data", operacao.Data);
                    Acesso.AdicionarParametros("@Local", operacao.Local);
                    Acesso.AdicionarParametros("@Destino", operacao.Destino);
                    Acesso.AdicionarParametros("@Origem", operacao.Origem);
                    Acesso.AdicionarParametros("@Historico", operacao.Historico);
                    Acesso.AdicionarParametros("@Valor", operacao.Valor);
                }
            }
        }
    }
}
