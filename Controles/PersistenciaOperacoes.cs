using Modelos;

namespace Controles
{
    class PersistenciaOperacoes : Persistencia
    {
        public override void EmpacotarParametros(object objeto, Metodo metodo)
        {
            Operacao operacao = (Operacao)objeto;
            acesso.LimparParametros();
            if (metodo == Metodo.Alterar || metodo == Metodo.Excluir)
            {
                acesso.AdicionarParametros("@Id", operacao.Id);
            }
            else
            {
                if (metodo == Metodo.Alterar || metodo == Metodo.Inserir)
                {                    
                    acesso.AdicionarParametros("@Data", operacao.Data);
                    acesso.AdicionarParametros("@Local", operacao.Local);
                    acesso.AdicionarParametros("@Destino", operacao.Destino);
                    acesso.AdicionarParametros("@Origem", operacao.Origem);
                    acesso.AdicionarParametros("@Historico", operacao.Historico);
                    acesso.AdicionarParametros("@Valor", operacao.Valor);
                }
            }
        }
    }
}
