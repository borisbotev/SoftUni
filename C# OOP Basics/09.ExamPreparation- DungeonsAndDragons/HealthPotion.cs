﻿public class HealthPotion
    : Item
{
    public HealthPotion()
        :base(5)
    {

    }

    public override void AffectCharacter(Character character)
    {
        base.AffectCharacter(character);

        character.Heal(20);
    }

}