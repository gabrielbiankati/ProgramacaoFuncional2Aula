using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoFuncional2Aula
{
    // Classe responsavel por gerar mensagens de notificação
    public static class NotificationService
    {

        // Porque esta é uma função pura?
        // 1 - Sem efeitos colaterais: Ela não modifica nenhum estado externo ou realiza operações de I/O

        // 2 - Determinística: Para os mesmos parametros de entrada, ela sempre retorna o mesmo resultado

        // 3 - Independente de estado externo: Não depende de variáveis ou estados que possam mudar fora de seu escopo

        // Porque ela não seria pura se chamasse o console.WriteLine?
        // Passaria a depender de algo externo (I/O) e isto seria um efeito colateral
        public static string Notify(User user, string message)
        {
            return $"Notificação para {user.Name}: {message}";
        }
    }
}
