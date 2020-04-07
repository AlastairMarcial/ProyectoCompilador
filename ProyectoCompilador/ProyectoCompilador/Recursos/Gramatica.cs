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
            NonGrammarTerminals.Add(comentarioLinea);
            NonGrammarTerminals.Add(comentarioBloque);
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
            KeyTerm mayorQue = ToTerm(">", "mayorQue");
            KeyTerm menorQue = ToTerm("<", "menorQue");
            KeyTerm igual = ToTerm("=", "igual");
            KeyTerm mayorIgual = ToTerm(">=", "mayorIgual");
            KeyTerm menorIgual = ToTerm("<=", "menorIgual");
            KeyTerm diferente = ToTerm("!=", "diferente");
            KeyTerm igualIgual = ToTerm("==", "igualIgual");

            //Variables
            KeyTerm varInt = ToTerm("int");
            KeyTerm varFloat = ToTerm("float");
            KeyTerm varString = ToTerm("string");
            KeyTerm varBoolean = ToTerm("bool");

            //Ciclos y condicionales
            KeyTerm condIf = ToTerm("if");
            KeyTerm condElif = ToTerm("elif");
            KeyTerm condElse = ToTerm("else");
            KeyTerm kwBreack = ToTerm("break");
            KeyTerm kwCase = ToTerm("case");
            KeyTerm kwClass = ToTerm("class");
            KeyTerm kwTry = ToTerm("Try");
            KeyTerm kwCatch = ToTerm("Catch");
            KeyTerm kwWhile = ToTerm("while");
            KeyTerm kwDowhile = ToTerm("do while");
            KeyTerm kwFor = ToTerm("for");
            KeyTerm kwPublic = ToTerm("public");
            KeyTerm kwThrow = ToTerm("Throw");
            KeyTerm kwVoid = ToTerm("Void");
            KeyTerm kwSwitch = ToTerm("Switch");
            KeyTerm kwTrue = ToTerm("true");
            KeyTerm kwFalse = ToTerm("False");

            #endregion

            #region Terminales
            NonTerminal ini = new NonTerminal("ini");
            NonTerminal instruccion = new NonTerminal("instruccion");
            NonTerminal instrucciones = new NonTerminal("instrucciones");
            NonTerminal expresion_numerica = new NonTerminal("expresion_numerica");
            NonTerminal expresion_cadena = new NonTerminal("expresion_cadena");
            NonTerminal expresion_logica = new NonTerminal("expresion_logica");
            #endregion

            #region No terminales
            #endregion

            #region Gramatica
            ini.Rule = instrucciones;

            #endregion

            #region Preferencias
            #endregion
        }
    }
}
