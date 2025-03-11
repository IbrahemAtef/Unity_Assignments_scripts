using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creatures = new() { new Duck(), new Kangaroo() };
            List<IRunnable> runnables = new();
            List<IJumpable> jumpable = new();
            List<ISwimmable> swimmable = new();

            var duck = creatures[0];
            var kangaroo = creatures[1];

            runnables.Add(kangaroo as IRunnable);
            runnables.Add(duck as IRunnable);
            swimmable.Add(duck as ISwimmable);
            jumpable.Add(kangaroo as IJumpable);

            foreach (Creature creature in creatures)
                creature.Speak();

            foreach (IRunnable creature in runnables)
                creature.Run();

            foreach (IJumpable creature in jumpable)
                creature.Jump();

            foreach (ISwimmable creature in swimmable)
                creature.Swim();

        }
    }
}
