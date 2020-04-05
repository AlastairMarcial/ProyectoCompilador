using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace ProyectoCompilador.Recursos
{
    class Gramatica:Grammar
    {
        public Gramatica():base(caseSensitive:true) 
        {

            #region er
            StringLiteral CADENA = new StringLiteral("cadena", "\"");
            var ENTERO = new NumberLiteral("entero");
            var DECIMAL = new RegexBasedTerminal("Decimal", "[0-9]+'.'[0-9]+");
            IdentifierTerminal IDENTIFICADOR = new IdentifierTerminal("ID");

            CommentTerminal comentarioBloque = new CommentTerminal("comentarioBloque", "/", "/");
            #endregion

            #region Terminales

            #endregion

            #region No terminales
            #endregion

            #region Gramatica
            #endregion

            #region Preferencias
            #endregion
        }
    }
}
