## Table of Contents
- [Introduction](#introduction)
- [Overview](#overview)
- [Features](#features)
  - [Search Functions](#search_functions)
  - [Query Constructors](#query_constructors)
  - [Error Checkers](#error_checkers)
  - [Applicant Information Retention](#applicant_information_retention)
  - [Real Time Updates](#real_time_updates)
- [Demo Video](#demo_video)

## Introduction

This is a demo application for my portfolio. This application is designed for social workers and welfare organizations to streamline workflow, keep track of and sort applications, and save relevant information. The application uses a Windows Forms .Net interface and connects to a SQL server.

## Overview

Program: a welfare program.
Application: an application submitted to a welfare program.
Applicant: the person that submitted the application.

![WorkFlowChart_lightmode](https://github.com/benhwlcode/WelfareApp/assets/141098928/0dc7fd59-5f3d-498a-a29c-2a2f0f1a0d83)

When an application is submitted, the information will be saved to different tables in the database. The application will link to its corresponding applicant and the program it applied to. Applications can then be queried to be worked on based on their shared program link. 

## Features

### Search Functions
- Quickly find the program they wish to work on.
- Filter applications and applicants that fit the criteria.

![search_feat_new](https://github.com/benhwlcode/WelfareApp/assets/141098928/f3d5da79-799c-4cff-a8b9-168edfa88342)

### Query Constructors
Construct complex SQL queries without expert knowledge.

![query_feat_new](https://github.com/benhwlcode/WelfareApp/assets/141098928/84076de7-c6d5-422f-be3b-18cbddfc4a7a)

### Error Checkers
Inform users of the specific error.

![errorcheck_feat_new](https://github.com/benhwlcode/WelfareApp/assets/141098928/9d8e4fad-88eb-438f-a85e-eb313f6e2d17)

### Applicant Information Retention
- Store applicant information to the database.
- Load stored applicant information from the database.
- Checks for duplicate applicants and applications.

![retention_feat_new](https://github.com/benhwlcode/WelfareApp/assets/141098928/f61501b7-7b24-45e4-bb35-c8181ad3d5fe)

### Real Time Updates
Ensures information is always in sync with database

![latest_feat_new](https://github.com/benhwlcode/WelfareApp/assets/141098928/58e0181f-1fc4-4ebd-b031-fdedc6b3a9ad)

## Demo Video

[EditFinalWebm.webm](https://github.com/benhwlcode/WelfareApp/assets/141098928/764ee188-7958-493e-8624-7cc62fe0f03e)











