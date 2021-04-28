namespace Set {
 public array <card> cardsInPlay;
 public array <card> cardsSelected;

 public void dealNewGame(){
     //returns cardsInPlay with array of cards
 }
 public bool checkIfSet(array cardsSelected){
    var Res = false;
    var Props = cardSelected[0].getProps();
    forEach(Props){
        if(Props.getValue(card[0]) == 
        Props.getValue(card[1]) == 
        Props.getValue(card[2] 
        || 
        Props.getValue(card[0]) != 
        Props.getValue(card[1]) != 
        Props.getValue(card[2])) {
            Res = true;
        }
        else{
            Res = false;
            break;
        }
    }
    return Res;
 }


}