text = input("Çevrilecek metin:")
result = ""
for i in text:
    result += format(ord(i), '08b')
    result += " "
print("Binary:", result)
