﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
               
                // Fundamentos

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Binários - Fundamentos", OperadoresBinarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                {"Operador Unário - Fundamentos", OperadorUnario.Executar},
                
                // Estruturas de Controle
                
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                
                // Classes & Métodos
                
                {"Membros - Classes & Métodos", Membros.Executar},
                {"Construtores - Classes & Métodos", Construtor.Executar},
                {"Métodos com Retorno - Classes & Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes & Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes & Métodos", AtributosEstaticos.Executar},
                {"Desafio Acessar Atributo - Classes & Métodos", DesafioAcessarAtributo.Executar},
                {"Params - Classes & Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes & Métodos", ParametrosNomeados.Executar},
                {"Getters & Setters - Classes & Métodos", GetSet.Executar},
                {"Props - Classes & Métodos", Props.Executar},
                {"Atributos Readonly - Classes & Métodos", AtributosReadonly.Executar},
                {"Enumerações Enum - Classes & Métodos", ExemploEnum.Executar},
                {"Struct - Classes & Métodos", ExemploStruct.Executar},
                {" Classe Vs Struct - Classes & Métodos", StructVsClasse.Executar},
                {" Valor Vs Referência - Classes & Métodos", ValorVsReferencia.Executar},
                {" Parâmetros por Referência - Classes & Métodos", ParametrosPorReferencia.Executar},
                {" Parâmetros com Valor Padrão - Classes & Métodos", ParametroPadrao.Executar},
                
                // Coleções

                {"Array - Coleções", UsandoArray.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecaoDictionary.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}