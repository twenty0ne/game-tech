﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAbilityTarget
{
    void Selected(Ability ability);
    void ApplyEffect(Effect effect);
}