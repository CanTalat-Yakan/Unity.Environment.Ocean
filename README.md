# Unity Essentials

This module is part of the Unity Essentials ecosystem and follows the same lightweight, editor-first approach.
Unity Essentials is a lightweight, modular set of editor utilities and helpers that streamline Unity development. It focuses on clean, dependency-free tools that work well together.

All utilities are under the `UnityEssentials` namespace.

```csharp
using UnityEssentials;
```

## Installation

Install the Unity Essentials entry package via Unity's Package Manager, then install modules from the Tools menu.

- Add the entry package (via Git URL)
    - Window → Package Manager
    - "+" → "Add package from git URL…"
    - Paste: `https://github.com/CanTalat-Yakan/UnityEssentials.git`

- Install or update Unity Essentials packages
    - Tools → Install & Update UnityEssentials
    - Install all or select individual modules; run again anytime to update

---

# Ocean

> Quick overview: Drop‑in ocean and pool water prefabs powered by a Shader Graph material and a tuned volume profile. URP/HDRP compatible. Tweak material parameters or the graph to fit your art style.

A simple, ready‑to‑use ocean surface for SRP projects. It ships with a Shader Graph‑based material, an ocean prefab sized for large scenes, a smaller pool variant for local bodies of water, and a volume profile with water‑related overrides you can assign to your scene’s Volume.

![screenshot](Documentation/Screenshot.png)

## Features
- Plug‑and‑play prefabs
  - `UnityEssentials_Prefab_Ocean.prefab`: large, horizon‑covering water surface
  - `UnityEssentials_Prefab_Pool.prefab`: smaller/local water surface
- Shader Graph material
  - `Ocean.mat` driven by `Resources/Shaders/Ocean.shadergraph`
  - Editable graph for color, normals, foam, and surface motion (adjust to your look)
- Volume profile
  - `Water Volume Profile.asset` with water/underwater‑related overrides for SRP Volume system
- SRP‑friendly
  - Built for URP/HDRP using Shader Graph and Volumes
  - Works with reflection probes/SSR/planar reflections depending on your pipeline settings

## Requirements
- Unity 6000.0+ (SRP: URP or HDRP)
- Shader Graph enabled in your pipeline
- Volume system active in your scene (Global or Local Volume)
- Optional: Planar reflections/SSR if you want reflective water; configure per pipeline

## Usage

1) Add the water surface
   - Drag `Resources/UnityEssentials_Prefab_Ocean.prefab` into your scene
   - Position at world origin (Y at your sea level) and scale as desired
   - For local bodies, use `UnityEssentials_Prefab_Pool.prefab`

2) Assign the volume profile
   - Ensure your scene has a Global Volume (or relevant local volume)
   - Assign `Resources/Volumes/Water Volume Profile.asset` to the Volume’s Profile slot
   - Merge its overrides into an existing profile if you maintain a single shared profile

3) Configure reflections (optional)
   - Add/position reflection probes for static reflections
   - Enable SSR or Planar Reflections per your pipeline for dynamic reflections

4) Tune the look
   - Select `Resources/Materials/Ocean.mat` and tweak properties (color, foam, normal tiling, speed)
   - Open `Resources/Shaders/Ocean.shadergraph` to adjust the shading/motion model
   - Duplicate the material for variants (shallow/deep, stormy/calm)

## Customization Tips
- Scale vs. tiling: when scaling the mesh for large scenes, adjust normal/foam tiling in the material to maintain detail density
- Color and depth: drive color by depth or normals in the Shader Graph for more believable edges and shallow areas
- Performance: keep graph complexity modest for large water surfaces; consider LOD meshes for distant water
- Volumes: copy only the water‑related overrides from `Water Volume Profile.asset` if you already have a scene profile

## Notes and Limitations
- Built‑in Render Pipeline is not supported; use URP or HDRP
- Underwater rendering, caustics, and shoreline interaction are not included; extend the graph or add custom effects
- Reflection quality depends on your probe/SSR/planar reflection configuration
- Large horizon water often benefits from fog and atmospheric scattering set in your Volume

## Files in This Package
- `Resources/UnityEssentials_Prefab_Ocean.prefab` – Ocean surface prefab
- `Resources/UnityEssentials_Prefab_Pool.prefab` – Smaller/local water prefab
- `Resources/Materials/Ocean.mat` – Water material
- `Resources/Shaders/Ocean.shadergraph` – Shader Graph driving the material
- `Resources/Volumes/Water Volume Profile.asset` – Volume overrides for water rendering
- `package.json` – Package manifest metadata

## Tags
unity, urp, hdrp, water, ocean, shadergraph, volume, reflections, environment, rendering
