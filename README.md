11-12-23
--

Got the invader to randomize and move towards the throat

I got the invader spawner to spawn invaders, but they don't move for whatever reason.

got past this I think with just translation
    Trying to get the collision detection to work when it reaches the throat area, but having trouble

    I got collision detection to work for a moment, but then the invader starts floating up for whatever reason

        https://stackoverflow.com/questions/69216504/vector3-movetowards-not-working-with-collisions

            "
            * at least one of your objects needs to have a rigidbody2d component
            * both need to have a 2d collider.
            * both need to be non-triggers
            
            but that's not all: as soon as you use physics you do not want to move your objects via transform in update since this overules the physics and thereby breaks collision detection.
            "
                so I can't use MoveTowards? what a pain in the.

                    maybe I can use MoveTowards but just not with the transoform. I'll try using the rigidbody instead.
                        
                        ok it kind of got better with rigidbody2d but as soon as it collides it starts going in a random direction lol

                            maybe i needed to do a path finding algorithm instead? jesus christ.

also my main camera keeps changing its width. it's so annoying.
