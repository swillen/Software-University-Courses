/**
 * Created by Veronica on 30.3.2015 г..
 */


function createParagraph(wrap, text){
    var element = document.getElementById(wrap);
    var text = text;
    var paragraph =document.createElement("p");
    paragraph.innerHTML=text;
    element.appendChild(paragraph);

};

createParagraph('wrapper','this is my text');