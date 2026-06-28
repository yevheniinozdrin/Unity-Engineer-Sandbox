# Unity Engineer Sandbox

A hands-on Unity engineering sandbox focused on production-ready workflows, performance optimization, and clean architecture.

This repository documents my journey of exploring modern Unity workflows, architectural patterns, and advanced engineering practices through small, self-contained projects inspired by real production challenges.

## 🎯 Objectives
* Build production-ready, scalable Unity examples.
* Master modern Unity architecture (Data-Driven, Modular).
* Minimize technical debt through strict code quality and maintainability.
* Deep-dive into Unity 6 core systems through practical implementation.
* Apply modern engineering practices to a live, commercial mobile game.

---

## 🧩 Featured Topics & Tech Stack
* **Architecture:** Modular Design, Assembly Definitions, ScriptableObjects, UI Architecture (MVP/MVVM patterns).
* **Memory & Assets:** Addressables (Asset Bundles), Object Pooling, Save Systems.
* **Performance:** Mobile Optimization (CPU load, thermal management, draw call reduction), URP.
* **Workflow:** Custom Editor Tooling, Automated Build Pipelines, Git/GitHub Actions.

---

## 💡 Project Philosophy
Each project in this repository focuses on solving a specific engineering bottleneck rather than simply demonstrating a Unity feature.

* **Problem:** How should immutable game data be organized without bloating memory?
  * **Solution:** Data-driven configurations using **ScriptableObjects**.
* **Problem:** How can large-scale Unity projects prevent tight coupling and long compile times?
  * **Solution:** Decoupling modules using **Assembly Definitions (AsmDef)**.
* **Problem:** How to reduce memory footprint and build size in content-heavy mobile apps?
  * **Solution:** Dynamic asset streaming via **Addressables**.

*The goal is to understand not only how Unity features work, but why they should be used and which specific engineering problems they solve.*

---

## 🚀 Long-Term Case Study
A core driver for this sandbox is the architectural refactoring of an active commercial mobile racing game. The goal is to isolate legacy systems, optimize physics/AI scripts for low-end Android devices, and transition the project to a scalable, multi-module architecture.
