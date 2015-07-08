var HTMLGen = new Object();
HTMLGen.createParagraph = function (id,text){

    var element = document.getElementById(id);
    var paragraph = document.createElement("p");
    paragraph.innerHTML=text;
    element.appendChild(paragraph);
};
HTMLGen.createLink = function (id,text,url){
    var element = document.getElementById(id);
    var link = document.createElement("a");
    link.href= url;
    link.innerHTML=text;
    element.appendChild(link);

};
HTMLGen.createDiv =function (id,clas){
    var element = document.getElementById(id);
    var div  = document.createElement("div");
    div.className=clas;
    element.appendChild(div);
};

HTMLGen.createParagraph('wrapper', 'Soft Uni');
HTMLGen.createDiv('wrapper', 'section');
HTMLGen.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');
