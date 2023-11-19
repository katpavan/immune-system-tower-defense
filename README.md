11-19-23
--

todo:
* stop the loop for the animations
* change to the next scene using invoke maybe

* have the white blood cells interact with the invaders based on their traits
* enable animations on white blood cells
* fix the resolution issue on itch page
* add in sounds and music
* add in game over animation

done:
* place the white blood cell where the mouse clicked
* added the health to white blood cells. Since they all have a cooldown of 1 minute, I'm not going to customize more for the time being
* I added in one voice over and the music, but the music plays once
* I also got lori's animation scenes in for the introduction, but they're looping

11-17-23
--

done:
* click white blood cell from hud, change cursor to it


11-13-23
--

todo:
* show game over when game is done and a play again button
* click white blood cell from hud, change cursor to it and then change cursor back when you click again and have it stay where you placed it
* check if animations work from lori and what adjustments are needed

done:
* Got the spawner to randomly spawn an invader
* Changed the spawn rate to 2.5 according to gdd
* change the speed, health, attack based off of the invader type

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
