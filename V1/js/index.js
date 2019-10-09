function trie() {
    //Initialisation
    var input, filter, table, tr, td, i, txtValue; //Déclaration des variables
    input = document.getElementById("Recherche"); //Variable input prend la valeur de la barre de recherche (ID = Recherche)
    filter = input.value.toUpperCase(); //Met la valeur de input en MAJUSCULE
    table = document.getElementById("table"); //Variable table prend la valeur des éléments du tableau (ID = table)
    tr = table.getElementsByTagName("tr"); //Variable tr prend la valeur de la balise tr du tableau "table" (TAG = tr)

    //Début de la recherche : Chercher chaque ligne de la table qui ne correspond pas à la rechercher et les masquer.
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}