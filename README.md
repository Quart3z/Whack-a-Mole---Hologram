# Whack-a-Mole-Hologram
Whack a Mole game done in hologram

We decided to make a multiplayer whacking mole game using Unity3D. We downloaded the hologram pyramid asset from the asset store to get a template of holographic display models. There are 4 separate faces where each face has one camera pointing toward the center of the main scene. Then, we make some models using Blender and exported them to the game which are egg, hole, and hammer. The hammer of its head rigidbody and collider, with eggs as a trigger so that eggs can be deactivated by the hammer. We wrote some scripts which are hammer script for trigger the animation of hitting and trigger detection, player movement for moving the hammer with a certain speed, game manager to control the pop-out of the eggs, score manager for recording the score of both players. 

The game concept is very simple. There are 9 holes on the platform where the eggs will pop out randomly for a certain period. If the players successfully hit one of the eggs, they will earn 1 point. The game will be ended with the winner who gets the first 5 points. By pressing ‘B’, the game will be restarted.

# Control Keys:

|Player 1 |Player 2 | Action|
|---------|---------|-------|
|W, A, S, D |Up, down, left, right arrow keys |movement |
|Alphabet numpad ‘1’  |Period key ‘.’ |whack |

<a href='https://youtu.be/rUjl3sK-_ik'>Demo video</a>

Created by:
- Looi Yao Wei	 
- Chai Cheah Wen	
