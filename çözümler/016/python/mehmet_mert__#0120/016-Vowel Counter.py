text = input("Metniniz:")
vowels = "euıüiaöo"
result = []
sentence = "Ünlüler:"
for i in text:
    if i in vowels:
        if i not in result:
            result += i
if result != []:
    print("Metninizdeki ünlü harfler:")
    print(*result, sep = ", ")
else:
    print("Cümlenizde ünlü harf bulunmuyor.")


        
