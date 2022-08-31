# Calculadora da área de figuras geométricas

Este exercício visa aplicar os primeiros conceitos aprendidos no módulo 2, o de POO I.

Neste exercício, possui-se uma classe "Pai" denominada Forma, que possui o método CalculaArea.

![image](https://user-images.githubusercontent.com/38474570/187725650-762b5106-d7b9-4735-bdba-2b92f0d90063.png)

Além da classe forma, possui-se outras classes que herdem da classe pai como a classe Quadrado.

![image](https://user-images.githubusercontent.com/38474570/187725922-dd1819a9-3100-4491-9034-516b299d51ec.png)

Neste caso, através de polimorfismo ela modifica a forma como o método CalculaArea irá agir quando for chamado.

Ela possui um construtor que solicita a entrada de um valor double, para definir o lado da figura quando for instanciado algum objeto.

Na Classe Program, vejamos o objeto quadrado sendo criado, passando como lado o numero 5.
![image](https://user-images.githubusercontent.com/38474570/187726425-eb6f1519-a468-415d-ae8e-3bbdd9734954.png)

Posteriormente o objeto quadrado chama o seu método calcular área, que irá usar o valor infomado (5) para calcular a área e irá exibir na tela. 
![image](https://user-images.githubusercontent.com/38474570/187726683-a86c03a5-4f57-4f1d-ba43-9f817ebdcb6a.png)
