# Physical Hands Playground

![Physical Hands Playground](https://github.com/ultraleap/PhysicsHandsPlayground/assets/6281246/e445cf49-d933-430a-bc7f-1ef0db46ab7f)

This repo is a living development and demo environment for [Ultraleap Physical Hands](https://docs.ultraleap.com/xr-and-tabletop/xr/unity/plugin/features/physical-hands.html). It centers around a core scene with multiple tables with varying types of interactable objects.

Notably this shows off an ideal project setup for Physical Hands, with a few helpful extra scripts and tools allowing you to try it out, or build off of it quickly.

As this is a living development environment we will have multiple branches that will very likely include current changes and experiments. It is recommended to rely on develop for (relatively) stable project setups.

## Getting Started

**This repo is a Unity project, and does not provide any builds.**

The project is using **[Unity 2022.3.30f1](https://unity.com/releases/editor/whats-new/2022.3.30)**.

You will need the same requirements as the [Ultraleap Unity Plugin](https://github.com/ultraleap/UnityPlugin/blob/develop/README.md#getting-started).

You will need to clone this repo through Git, making sure to initialise LFS and all submodules. As this is primarily a development environment, we don't always follow specific releases of our Unity Plugin.

We include a [package for improved colliders](https://github.com/rorygames/VHACD) which requires Git to be installed on your system (Unity uses it to clone the package). You can manually replace this with a [local copy](https://docs.unity3d.com/Manual/upm-ui-local.html) instead if you prefer.

## XR Setup

This project is setup to use OpenXR on Windows. You will need to make sure you have enabled the OpenXR Hand Tracking setting in the Ultraleap Tracking Control Panel.

You may need to include other packages for specific platforms such as Pico or Vive to enable this to work on their standalone headsets. This should also work on Quest headsets with their hand tracking through OpenXR, but is not directly supported or tested.

## What's Included

- Different tables covering different types of interaction such as:
  - Shapes 📦
  - Figures 🐕
  - Toys 🪀
- A simple hand menu with button interactions
- Ideal Unity settings for Physical Hands

## Feedback

We love hearing feedback about Physical Hands! You can chat to us via [Github Discussions](https://github.com/ultraleap/UnityPlugin/discussions).

While we can't provide support for every platform or use case, as this is currently a live development environment you can be fairly sure things should be working as intended 🙂🤞

Made with ♥ by [@rorygames](https://github.com/rorygames) and [@dwarph](https://github.com/Dwarph/)