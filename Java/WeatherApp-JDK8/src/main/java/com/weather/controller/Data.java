/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.weather.controller;

import com.google.gson.Gson;
import com.google.gson.JsonArray;
import com.google.gson.reflect.TypeToken;
import com.weather.pojo.City;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.Writer;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/**
 *
 * @author Wong
 */
public class Data {
    
    public List<String> data;
    
    public void loadFromJson() throws FileNotFoundException{
        data = new ArrayList<>();
        Gson gson = new Gson();
        
    }
    
    public void updateData(List<String> lista) throws IOException{
        Writer jsonWriter = new FileWriter(getClass().getResource("/com/weather/json/history.json").getPath());
        Gson gson = new Gson();
        JsonArray array = (JsonArray) gson.toJsonTree(lista, 
                new TypeToken<List<City>>(){
        }.getType());
        gson.toJson(array,jsonWriter);
    }
}
