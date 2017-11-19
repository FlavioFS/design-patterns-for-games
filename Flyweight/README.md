# Flyweight

## Classification
> Purpose: Structural  
> Scope: Object

## Description
Separates shared data into a different object to reduce memory consumption.

When a class shares same attribute values among a huge amount of instances, it is better for performance to move that shared data into a new class.

## Roadmap
 1. Identify shared data within a class A.
 2. Create a new class B (or AModel) and move shared attributes to it.
 3. Add a new attribute to A which is a **reference** to B.

## When should I use it?
 - When performance is critical.
 - When profiler tells you to do so.
 - When a collection shares significant data among instances.
  - When the game spawns a lot of minions.
  - When the world has *over 9000* trees using same mesh and textures.
 - When the world is grid-based.
  - When you are implementing a tilemap.
  - When you are implementing a voxelmap.

## Real Scenario
### Tilemap System
This section is under construction.