public class PokemonEntityFromJson
{
    public int Id { get;  set; }
    public string Name { get;  set; }
    public _SpritesFromJson sprites { get;  set; }
    public int Height { get;  set; }
    public int Weight { get;  set; }
    public ICollection<_AbilitiesFromJson> Abilities { get; set; }
    public ICollection<_TypesFromJson> Types { get; set; }

    public class _SpritesFromJson
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
    }

    public class _AbilitiesFromJson
    {
        public _AbilityFromJson Ability { get; set; }
    }

    public class _AbilityFromJson
    {
        public string Name { get; set; }
    }

    public class _TypesFromJson
    {
        public _TypeFromJson Type { get; set; }
    }
    
    public class _TypeFromJson
    {
        public string Name { get; set; }
    }
}