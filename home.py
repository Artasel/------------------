# Реализуйте 3 метода, чтобы в каждом из них получить разные исключения

def delNull(x: int, y: int):
    """
    Делить на ноль нельзя
    """
    try:
        print(x / y)
    except:
        print("Делить на ноль нельзя")
   
def exitZaGran(x: int, list):
    if len(list) >= x:
        print(list[x])
    else:
        print("Индекс передан больше, чем длина массива")

def nullElement(stroka: str, list):
    if stroka in list:
        print("Элемент в списке присутствует")
    else:
        print("Элемента нет в списке")



delNull(123, 0)

listRes = [123, 43, 532, 24, 42]

exitZaGran(123, listRes)

listRes2 = ["qwe", "ewq", "asddsa"]

nullElement("qwde", listRes2)