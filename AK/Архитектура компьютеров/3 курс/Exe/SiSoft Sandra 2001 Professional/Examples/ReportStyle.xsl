<?xml version="1.0"?>
<HTML xmlns:xsl="http://www.w3.org/TR/WD-xsl">

<BODY>

<xsl:for-each select="Module">
  <h2><xsl:value-of select="Title"/></h2>

  <xsl:for-each select="DeviceClass">
    <h3><xsl:value-of select="Title"/></h3>

    <xsl:for-each select="Device">
      <h3><xsl:value-of select="Title"/></h3>

      <xsl:for-each select="InfoGroup">
        <h4><xsl:value-of select="Title"/></h4>

        <xsl:for-each select="InfoItem">
          <DIV CLASS="field"><xsl:value-of select="Title"/> : <xsl:value-of select="Value"/></DIV>
        </xsl:for-each>

      </xsl:for-each>
    </xsl:for-each>
  </xsl:for-each>

  <xsl:for-each select="Device">
    <h3><xsl:value-of select="Title"/></h3>

    <xsl:for-each select="InfoGroup">
      <h4><xsl:value-of select="Title"/></h4>

      <xsl:for-each select="InfoItem">
        <DIV CLASS="field"><xsl:value-of select="Title"/> : <xsl:value-of select="Value"/></DIV>
      </xsl:for-each>

    </xsl:for-each>
  </xsl:for-each>

  <xsl:for-each select="InfoGroup">
    <h4><xsl:value-of select="Title"/></h4>

    <xsl:for-each select="InfoItem">
      <DIV CLASS="field"><xsl:value-of select="Title"/> : <xsl:value-of select="Value"/></DIV>
    </xsl:for-each>

  </xsl:for-each>

  <xsl:for-each select="InfoItem">
      <DIV CLASS="field"><xsl:value-of select="Title"/> : <xsl:value-of select="Value"/></DIV>
  </xsl:for-each>

</xsl:for-each>


</BODY>
</HTML>