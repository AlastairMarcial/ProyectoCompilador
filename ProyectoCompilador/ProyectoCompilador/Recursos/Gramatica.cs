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
            RegexBasedTerminal letras = new RegexBasedTerminal("letras", "[(a-z)*(A-Z)*(0-9)*]+");
            var ENTERO = new NumberLiteral("entero");
            var DECIMAL = new RegexBasedTerminal("Decimal", "[0-9]+'.'[0-9]+");
            IdentifierTerminal IDENTIFICADOR = new IdentifierTerminal("ID");

            //CommentTerminal comentarioBloque = new CommentTerminal("comentarioBloque", "/", "/");

            CommentTerminal comentarioLinea = new CommentTerminal("SingleLineComment", "//", "\r", "\n", "\u2085", "\u2028", "\u2029");
            CommentTerminal comentarioBloque = new CommentTerminal("DelimitedComment", "/*", "*/");
            NonGrammarTerminals.Add(SingleLineComment);
            NonGrammarTerminals.Add(DelimitedComment);
            #endregion

            #region KeyWords de Puntuacion
            KeyTerm dosPuntos = ToTerm(":", "dosPuntos");
            KeyTerm puntoComa = ToTerm(";", "puntoComa");
            KeyTerm punto = ToTerm(".", "punto");
            KeyTerm coma = ToTerm(",", "coma");
            KeyTerm parentesisIzq = ToTerm("(", "parentesisIzq");
            KeyTerm parentesisDer = ToTerm(")", "parentesisDer");
            KeyTerm llaveIzq = ToTerm("{", "llaveIzq");
            KeyTerm llaveDer = ToTerm("}", "llaveDer");
            #endregion

            #region KeyWords Operadores, Comparadores, nombre variables, 
            KeyTerm plus = ToTerm("+", "plus");
            KeyTerm minus = ToTerm("-", "minus");
            KeyTerm por = ToTerm("*", "por");
            KeyTerm div = ToTerm("/", "div");
            KeyTerm plusPlus = ToTerm("++", "plusPlus");
            KeyTerm minusMinus = ToTerm("--", "menosMenos");

            //Comparadores
            KeyTerm mayorQue = toTerm(">", "mayorQue");
            KeyTerm menorQue = toTerm("<", "menorQue");
            KeyTerm igual = toTerm("=", "igual");
            KeyTerm mayorIgual = toTerm(">=", "mayorIgual");
            KeyTerm menorIgual = toTerm("<=", "menorIgual");
            KeyTerm diferente = toTerm("!=", "diferente");
            KeyTerm igualIgual = toTerm("==", "igualIgual");

            //Variables
            KeyTerm varInt = toTerm("int");
            KeyTerm varFloat = toTerm("float");
            KeyTerm varString = toTerm("string");
            KeyTerm varBoolean = toTerm("bool");

            //Ciclos y condicionales
            KeyTerm condIf = toTerm("if");
            KeyTerm condElif = toTerm("elif");
            KeyTerm condElse = toTerm("else");
            KeyTerm kwBreack = toTerm("break");
            KeyTerm kwCase = toTerm("case");
            KeyTerm kwClass = toTerm("class");
            KeyTerm kwTry = toTerm("Try");
            KeyTerm kwCatch = toTerm("Catch");
            KeyTerm kwWhile = toTerm("while");
            KeyTerm kwDowhile = toTerm("do while");
            KeyTerm kwFor = toTerm("for");
            KeyTerm kwPublic = toTerm("public");
            KeyTerm kwThrow = toTerm("Throw");
            KeyTerm kwVoid = toTerm("Void");
            KeyTerm kwSwitch = toTerm("Switch");
            KeyTerm kwTrue = toTerm("true");
            KeyTerm kwFalse = toTerm("False");

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
