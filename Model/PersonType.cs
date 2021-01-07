namespace Model
{
    public enum PersonType
    {
        Customer, Employee, Manager
        //manager kan alle incidenten zien en mag users aanmaken.
        //employee kan alle incidenten zien en incidenten maken en de andere users zien maar geen users aanmaken
        //customer kan alleen zijn eigen incidenten zien, DUS GEEN ANDER SCHERM KAN HIJ OPENEN ZONDER NEW INCIDENT KNOP, dus mag ook geen user management zien
    }
}
