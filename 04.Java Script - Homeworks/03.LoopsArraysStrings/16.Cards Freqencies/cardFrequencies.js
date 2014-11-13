function findCardFrequency(value) {
    var cards = value.replace(/[♥♣♠♦]+/g, '').split(" ");
    var counter = 1;
    var arrFrequency = new Array();
    var n = cards.length;
    for (var i = 0; i < cards.length; i++) {
        for (var j = 0; j < cards.length; j++) {
            if (cards[i] == cards[j] && i != j && j > i) {
                counter++;
                cards.splice(j, 1);
                j--;
            }
        }
        arrFrequency.push(((counter/n)*100).toFixed(2)+"%");
        counter = 1;
    }
    for (i = 0; i < cards.length; i++) {
        console.log(cards[i] + " -> " + arrFrequency[i]);
    }
}
//findCardFrequency('8♥ 2♣ 8♦ 8♦ J♥ A♠ K♦ 10♥ K♠ K♦');
findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
findCardFrequency('10♣ 10♥');