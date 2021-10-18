i =1 
numeros =[]
print("Digite uma sequência de dez números: \n\n")

while i <=10:
    numero = int(input('Digite o número {} : '.format(i)))

    numeros.append(numero)

    i = i+1
while True:
    numero_busca = int(input('Digite o número que deseja buscar na lista: '))

    if(numero_busca in numeros):
        print('\nO número {} foi encontrado som sucesso'.format(numero_busca))
        if(numero_busca %2 == 0):
            print('\nO número {} é par'.format(numero_busca))
        else:
            print('\nO número {} é ímpar'.format(numero_busca))
    else:
        print('O número {} não foi localizado na lista'.format(numero_busca))