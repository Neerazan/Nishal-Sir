#pass by reference
class Person:
    
    def __init__(self,name,gender):
        self.name = name
        self.gender = gender
        
def greet(other):
    print("Hi my name is ",other.name, " and i am a ",other.gender)
    p1 = Person("selana","female")
    return p1
p = Person("Nirajan","Male")
x = greet(p)
print(x.name)
print(x.gender)
