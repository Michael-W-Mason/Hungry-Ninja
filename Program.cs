Buffet goldenCorral = new Buffet();
Ninja person = new Ninja();
while(!person.IsFull){
    Food item = goldenCorral.Serve();
    person.Eat(item);
}