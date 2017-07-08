﻿
ublic Quaternion Bezier( float u, List<Quaternion> vList ) {
{    // If there is only one element in vList, return it
{    if (vList.Count == 1) {
{        return( vList[0] );
{    }
{    // Otherwise, create vListR, which is all but the 0th element of vList
{    // e.g. if vList = [0,1,2,3,4] then vListR = [1,2,3,4]
{    List<Quaternion> vListR =  vList.GetRange(1, vList.Count-1);
{    // And create vListL, which is all but the last element of vList
{    // e.g. if vList = [0,1,2,3,4] then vListL = [0,1,2,3]
{    List<Quaternion> vListL = vList.GetRange(0, vList.Count-1);
{    // The result is the Slerp of these two shorter Lists
{    // It's possible that Quaternion.Slerp may clamp u to [0..1] :(
{    Quaternion res = Quaternion.Slerp(Bezier(u,vListL), Bezier(u,vListR), u);
{    return( res );
{}
{
{// This version allows an Array or a series of Quaternions as input
{static public Quaternion Bezier( float u, params Quaternion[] vecs ) {
{	return( Bezier( u, new List<Quaternion>(vecs) ) );
{} 
