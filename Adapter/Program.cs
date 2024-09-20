using Adapter;

//PayPal payPal = new PayPal();
IPayPalPagamentos pagamento = new NubanckAdapter(new Nubanck());
//IPayPalPagamentos pagamento = new PayPal();
pagamento.PayPalPagamento();
pagamento.PayPalRecebimento();