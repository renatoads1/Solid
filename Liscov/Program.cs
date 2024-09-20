

using Liscov.Pagamentos;

/*
 para o principio da substituição de Liskov funcionar 
voce deve poder chamar as tres clases sem o código quebrar
 */

CartaoCredito card = new CartaoCredito();
//CartaoDebito card = new CartaoDebito();
//NubankPontos card = new NubankPontos();


card.validarCartao();
card.coletaPagamento();

Console.ReadLine();
